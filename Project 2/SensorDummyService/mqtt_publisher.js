
const mqtt = require('mqtt');
const exspress = require('express');




// MQTT broker URL
const clientId = 'mqttx_b65b6a77';
const clientId2 = 'mqttx_b65b6a77';

const username = 'sensor_dummy';
const password = 'sensor_dummy';
const topic = 'airpi_topic';
const qos = 0;

let i = 0;
data = [];

const address = 'mqtt://172.26.176.1:1883'; // 'mqtt://broker.emqx.io:1883'
const client = mqtt.connect(address, {
	clientId,
	
});

// MQTT client options
const options = {
  clientId: "mqtt_publisher", // unique identifier for the client
};




// Connect to the MQTT broker
//const client = mqtt.connect(brokerUrl, options);

// Handle MQTT connection events

client.on("error", (error) => {
  console.error("Error:", error);
});

// Reading sensor data from database

const dummyObject = {
  humidity: "20",
  temperature: "30ssssss",
};

const fs = require('fs');
const { parse } = require('csv-parse');
const parser = parse({ columns: true }, function (err, records) {
  records.forEach((record) => {
    // Preskoči prve dve kolone (column1 i column2)
    for (const key in record) {
      if (key !== 'Id' && key !== 'Date_time') {
        record[key] = parseFloat(record[key]);
      }
    }
  });
	data = records;
	setInterval(sendRow, 3000);
});

fs.createReadStream('./AirPi Data - AirPi.csv').pipe(parser);

function sendRow() {
  const rowData = data[i];
  //const floatValue = parseFloat(rowData.Air_Quality);
	client.publish(topic, JSON.stringify(rowData), { qos }, (error) => {
		console.log('sensor_dummy sending: ', rowData);
		if (error) {
			console.error('ERROR: ', error);
		}
	});
	i = (i + 1) % data.length;
}






// async function sendValue() {
//   try {
//       let valueId = Math.floor(Math.random() * 10000);
//       console.log(valueId);
//       let value = await database.promise()
//           .query(`SELECT * FROM AirPi_Values WHERE Id = '${valueId}'`);

//       console.log(value);
//       client.publish(topic, JSON.stringify(value[0][0]));
//       console.log('Poslato:', JSON.stringify(value[0][0]) );

//   }
//   catch (error) {
//       console.log(error);
//   }
// }

// setInterval(sendValue, 2000);
// Publish a message to a topic


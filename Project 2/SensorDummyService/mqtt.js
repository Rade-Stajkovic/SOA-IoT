const database = require('./dbconfig');
const mqtt = require('mqtt');
const exspress = require('express');




// MQTT broker URL
const clientId = 'mqttx_b65b6a';
const clientId2 = 'mqttx_b65b6a77';

const username = 'sensor_dummy';
const password = 'sensor_dummy';
const topic = 'testtopic';
const qos = 0;
const address = 'mqtt://emqx@127.0.0.1:1883'; // 'mqtt://broker.emqx.io:1883'
const client = mqtt.connect(address, {
	clientId,
	
});

client.subscribe(topic, (err) => {
    if (!err) {
      console.log('Pretplaćen na topic mqtt_topic');
    }
  });

  client.on('message', (topic, message) => {
    console.log(`Poruka sa topica ${topic}: ${message}`);
  });
  
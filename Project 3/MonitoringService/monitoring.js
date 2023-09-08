const mqtt = require('mqtt')
const clientId = 'monitoring'
const username = 'monitoring'
const password = 'monitoring'
const edgexTopic = 'YOUR-UNIQUE-TOPIC'
let currentState = 'OFF'

const address = 'tcp://broker.hivemq.com:1883'

const mqttClient = mqtt.connect(address, {
    clientId,
    username,
    password
})

mqttClient.subscribe(edgexTopic, () => {
    console.log(`monitoroin service subscribed to ${edgexTopic}`)
})

mqttClient.on('message', (topic, payload) => {
    if (topic !== edgexTopic) return;

    const data = JSON.parse(payload.toString())
    if (data.device !== 'SensorValueCluster2') return;
    const no2 = data.readings[0].value
    console.log(`NO2 concentration is ${no2}`)

    if (co2 < 1490)
    {
        currentState = 'green'
        console.log('CURRENT STATE CHANGED TO GREEN')
        sendAlert()
        return
    }
    
    if (co2 > 1600)
    {
        currentState = 'red'
        console.log('CURRENT STATE CHANGED TO RED')
        sendAlert()
        
    }
     
    currentState = 'yellow'
    console.log('CURRENT STATE CHANGED TO YELLOW')
    sendAlert()
    

})

async function sendAlert()
{
	const url =
		'http://172.26.176.1:48082/api/v1/device/9c4445bf-4743-45f1-8884-28aea58d8b18/command/a357b758-2fc7-4858-b6b9-0a67f14f8225';


	const body = {
		state: currentState,
	};
	try {
		const res = await fetch(url, {
			method: 'PUT',
			headers: { 'Content-Type': 'application/json' },
			body: JSON.stringify({ body }),
		});
		console.log(res);
	} catch (ex) {
		console.log(ex);
	}
}

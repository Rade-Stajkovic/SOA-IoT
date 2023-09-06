const express = require('express')
const bodyParser = require('body-parser');
const cors = require('cors');
const port = 3000;

const dboperations = require('./dboperations');

const app = express();
const router = express.Router();

app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());
app.use(cors());
app.use('/api', router);


router.route('/airpi/values').get( async (request,response)=>{
    await dboperations.getAirPiValues().then(result => {
       response.json(result[0]);
    })

})

router.route('/airpi/:valueId').get( async (request,response)=>{
    await dboperations.getValue(request.params.valueId).then(result => {
       response.json(result[0]);
    })
})

router.route('/airpi/').post( async (request,response)=>{
    try {
        const value = {...request.body}
        await dboperations.addValue(value).then(result => {
            response.status(201).json(result[0]);
           
        })
    } catch (error) {
        
    }
})

router.route('/airpi/update').put( async (request,response)=>{
    try {
        const value = {...request.body}
        await dboperations.updateValue(value).then(result => {
            response.status(201).json(result[0]);
           
        })
    } catch (error) {
        
    }
})

router.route('/airpi/delete/:valueId').delete( async (request,response) =>{
    try {
        console.log("delete...");
        await dboperations.deleteValue(request.params.valueId).then(result => {
            response.status(200).send({ messsage: 'Successfully deleted' });
        })
    } catch (error) {
        
    }
})

app.listen(port);
console.log('AirPi API is runnning at ' + port);
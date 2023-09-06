const database = require('./dbconfig');
const mysql = require('mysql2');


async function  getAirPiValues () {
    try {
        const results = await database.promise().query('SELECT * from AirPi_Values');
        //res.status(200).send(results[0]);
        
        return results;
    } catch (error) {
        console.log(error);
        
    }
     
    }

// async function getAirPiValues() {
//     try {
//         let pool = await mysql.connect(config);
//         let values = await database.promise().query("SELECT * from AirPiValues")
//         return value;
//     } 
//     catch (error) {
//         console.log(error);
        
//     }
// }

async function getValue(valueId) {
    try {
        console.log(valueId);
        let value = await database.promise()
            .query(`SELECT * FROM AirPi_Values WHERE Id = '${valueId}'`);

        console.log(value);
        return value;

    }
    catch (error) {
        console.log(error);
    }
}

async function addValue(value)
{
    try {
        await database.promise()
        .query(`INSERT INTO AirPi_Values(Id,Date_time,Volume,Light_Level,Temperature_DHT,Pressure, Temperature_BMP, Relative_Humidity, Air_Quality, Carbon_Monoxide, Nitrogen_Dioxide) VALUES('${value.Id}', '${value.Date_time}', ${value.Volume}, ${value.Light_Level}, ${value.Temperature_DHT}, ${value.Pressure}, ${value.Temperature_BMP}, ${value.Relative_Humidity}, ${value.Air_Quality}, ${value.Carbon_Monoxide}, ${value.Nitrogen_Dioxide})`);
       
        let result = await database.promise().query(`SELECT * FROM AirPi_Values WHERE Id = '${value.Id}'`);
       
        return result;
    } catch (error) {
        
    }
}

async function updateValue(value)
{
    try {
        await database.promise()
        .query(`UPDATE AirPi_Values SET Id='${value.Id}',Date_time='${value.Date_time}',Volume='${value.Volume}',Light_Level='${value.Light_Level}',Temperature_DHT='${value.Temperature_DHT}',Pressure='${value.Pressure}',Temperature_BMP='${value.Temperature_BMP}',Relative_Humidity='${value.Relative_Humidity}',Air_Quality='${value.Air_Quality}',Carbon_Monoxide='${value.Carbon_Monoxide}',Nitrogen_Dioxide='${value.Nitrogen_Dioxide}' WHERE Id = '${value.Id}'`);
       
        let result = await database.promise().query(`SELECT * FROM AirPi_Values WHERE Id = '${value.Id}'`);
       
        return result;
    } catch (error) {
        
    }
}

async function deleteValue(valueId)
{
    try {
        console.log("db delete");
        let result = await database.promise().query(`DELETE FROM AirPi_Values WHERE Id = '${valueId}'`);
        console.log("return");
        return result;
    } catch (error) {
        
    }
}

module.exports = {
    getAirPiValues: getAirPiValues,
    getValue : getValue,
    addValue : addValue,
    updateValue : updateValue,
    deleteValue : deleteValue

}

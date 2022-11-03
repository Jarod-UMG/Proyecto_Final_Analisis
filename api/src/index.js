import app from "./app"; 
const PORT = process.env.PORT || 4000;
const eurekaHelper = require('./eureka-helper');
eurekaHelper.registerWithEureka('NODEJSAPI', PORT);

const main=()=>{
    app.listen(app.get("port"));
    console.log(`server on port ${app.get("port")}`);
};

main();


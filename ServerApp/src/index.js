const express = require('express');
const soap = require('soap');

const procedureRouter = require("./routes/procedures.routes");
const viewRouter = require("./routes/views.routes");

const service_orders = require("./soap/service");
const xml_orders = require("./soap/wsdl");

const PORT = process.env.PORT || 50;

const app = express();

app.get('/', (req, res) => {
  res.send(
  "<img src='https://www.film.ru/sites/default/files/images/obi-wan-hello-there.jpg' />" + 
  "<br><H1>hello there </H1><br>");
});
app.use(express.json());

// требуется для Angular's Apps
// настройка CORS
app.use(function (req, res, next) {
  res.header("Access-Control-Allow-Origin", "*");
  res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
  res.header("Access-Control-Allow-Methods", "GET, PATCH, PUT, POST, DELETE, OPTIONS");
  next();  // передаем обработку запроса методу app.post("/postuser"...
});

app.use('/api/view', viewRouter);
app.use('/api/proc', procedureRouter);
var server = app.listen(PORT, () => console.log("Server started on " + PORT));
soap.listen(server, '/interation', service_orders, xml_orders);//взаимодействие с orders
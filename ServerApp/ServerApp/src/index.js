const express = require('express');

const procedureRouter = require("./routes/procedures.routes");
const viewRouter = require("./routes/views.routes");
const PORT = process.env.PORT || 80;

const app = express();

app.get('/', (req, res) =>{ res.send("hello there") });
app.use(express.json());
// настройка CORS
app.use(function(req, res, next) {
    res.header("Access-Control-Allow-Origin", "*");
    res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
    res.header("Access-Control-Allow-Methods", "GET, PATCH, PUT, POST, DELETE, OPTIONS");
    next();  // передаем обработку запроса методу app.post("/postuser"...
  });
app.use('/api/view', viewRouter);
app.use('/api/proc', procedureRouter);
app.listen(PORT, ()=>console.log("Server started on " + PORT));

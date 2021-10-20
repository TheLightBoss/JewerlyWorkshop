const express = require('express');

const procedureRouter = require("./routes/procedures.routes");
const viewRouter = require("./routes/views.routes");
const PORT = process.env.PORT || 80;

const app = express();

app.get('/', (req, res) =>{ res.send("hello there")});
app.use(express.json());

app.use('/view/api', viewRouter);
app.use('/proc/api', procedureRouter);
app.listen(PORT, ()=>console.log("Server started on " + PORT));

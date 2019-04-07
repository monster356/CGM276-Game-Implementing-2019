var io = require('socket.io')(process.env.PORT || 3000);

console.log("serverStarted");

io.on("connection",function(socket){

    console.log("clientConnected");
});
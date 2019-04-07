var io = require('socket.io')(process.env.PORT || 3000);

console.log("serverStarted");

var playarcount = 0;

io.on("connection", function (socket) {

    console.log("clientConnected");

    socket.broadcast.emit('spawn');
    playarcount++;

    for (i = 0; i < playarcount; i++) {
        socket.emit("spawn");
        console.log("spawn existing player");
    }

    socket.on("move", function (data) {
        console.log("move");
    })

    socket.on("disconnect", function () {
        console.log("client disconnect");
        playarcount--;
    })
});
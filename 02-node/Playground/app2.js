function readFile(callback){
    //callback();
    console.log(callback)
}

var x = function(){
    console.log("read file");
}

readFile(x);
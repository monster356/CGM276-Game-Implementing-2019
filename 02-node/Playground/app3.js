
var callback = function(param){
    console.log("do something : ",param)
}
var x = function(){
    console.log("hello");
}
function myFunction(param,func){
    func(param);

}
myFunction("Say",x);
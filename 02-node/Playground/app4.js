function myFunction(param,func){
    func(param)
}
myFunction("Say",function(param){console.log("Do something : ",param)});
function stringAnagrams(string, hold = "", result = []){
    if(string.length==0){
        return result.push(hold);
    }else{
        var tempH = "";
        var arr = string.split("");
        for(var i = 0; i<arr.length; i++){
            var tempS = "";
            tempH = hold + arr[i];
            for(j = 0; j <arr.length; j++){
                if(j!=i){
                    tempS+= arr[j];
                }
            }
        stringAnagrams(tempS, tempH, result);
        }
    }
    return result;
}
console.log(stringAnagrams("abc"));
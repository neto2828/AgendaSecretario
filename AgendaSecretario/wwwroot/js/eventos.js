//Puedes guardar tu lista en una variable con formato json 
var modal = @Html.Raw(Json.Encode(Model));

//Y recorres todas las claves que te devuelve el json con los valores
function recorrerModal() {
    for (var i in modal) {
        console.log(i, modal[i]);
    }
}
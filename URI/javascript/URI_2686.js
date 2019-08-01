var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

var frase = ["Bom Dia!!", "Boa Tarde!!", "Boa Noite!!", "De Madrugada!!"];
while(lines.length > 0){
    var graus = parseFloat(lines.shift())%360;
    var s = parseInt((graus * 240)%60);
    var m = parseInt(((graus * 240)/60)%60);
    var h = (parseInt(((graus * 240)/60)/60) + 6)%24;
    s = s < 10 ? "0" + s : s;
    m = m < 10 ? "0" + m : m;
    h = h < 10 ? "0" + h : h;

    if(graus >= 0 && graus < 90)
        console.log(frase[0]);
    else if(graus >= 90 && graus < 180)
        console.log(frase[1]);
    else if(graus >= 180 && graus < 270)
        console.log(frase[2]);
    else
        console.log(frase[3]);
    console.log(h + ":" + m + ":" + s);
}
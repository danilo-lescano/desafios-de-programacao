var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

function Estrutura(){
    return{
        cabeca: false,
        vazio: true,
        ehPalavra: false,
        letra: "",
        next: [],
        tam: 0,

        add: function(str, tam){
            if(this.cabeca){
                for(var i = 0; i <= this.next.length; i++) {
                    if(i === this.next.length){
                        this.next[this.next.length] = Estrutura();
                        this.next[this.next.length - 1].add(str, 1);
                        break;
                    }
                    else if(this.next[i].letra === str.substring(0, 1)){
                        this.next[i].add(str, 1);
                        break;
                    }
                }
            }
            else if(this.vazio){
                this.letra = str.substring(0, 1);
                this.tam = tam;
                this.vazio = false;
                if(str.substring(1) !== ""){
                    this.next[0] = Estrutura();
                    this.next[0].add(str.substring(1), tam+1);
                }
                else
                    this.ehPalavra = true;
            }
            else{
                if(str.substring(1) === ""){
                    this.ehPalavra = true;
                    return;
                }
                for(var i = 0; i <= this.next.length; i++) {
                    if(i === this.next.length){
                        this.next[this.next.length] = Estrutura();
                        this.next[this.next.length - 1].add(str.substring(1), tam+1);
                        break;
                    }
                    else if(this.next[i].letra === str.substring(1, 2)){
                        this.next[i].add(str.substring(1), tam+1);
                        break;
                    }
                }
            }
        },

        print: function(str){
            str += this.letra;
            if(this.ehPalavra && !this.cabeca){
                console.log(str + " " + this.tam);
            }
            for (let i = 0; i < this.next.length; i++)
                this.next[i].print(str);
        },

        quantidade: function(str, tam){
            var cont = 0;
            var aux = [0, 0];
            if(this.ehPalavra && !this.cabeca && str.substring(1) === ""){
                cont++;
                if(tam < this.tam)
                    tam = this.tam;
            }

            for (let i = 0; i < this.next.length; i++){
                if(this.cabeca && str.substring(0, 1) === this.next[i].letra){
                    aux = this.next[i].quantidade(str, tam);
                    cont += aux[0];
                }
                else if(!this.cabeca && (str.substring(1, 2) === this.next[i].letra || str.substring(1) === "")){
                    aux = this.next[i].quantidade(str.substring(1), tam);
                    cont += aux[0];
                }
            }
            return [cont, tam > aux[1] ? tam : aux[1]];
        }
    };
}

//var num_words = 5;
var num_words = parseInt(lines.shift());
var words = Estrutura();
words.cabeca = true;

for (let j = 0; j < num_words; j++) {
    //words.add(["maratonaicpc","maraton","programacao","progress","inputs"][j], 0)
    words.add(lines.shift(), 0);
}
//num_words = 3;
num_words = parseInt(lines.shift());
for (let j = 0; j < num_words; j++) {
    //var arr = words.quantidade(["marat","programacao","outputs",][j], 0);
    var arr = words.quantidade(lines.shift(), 0);
    if(arr[0] === 0 && arr[1] === 0)
        console.log(-1);
    else
        console.log(arr[0] + " " + arr[1]);
}
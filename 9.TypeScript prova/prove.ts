import * as readline from 'readline';
readline.emitKeypressEvents(process.stdin);
process.stdin.setRawMode(true);
process.stdin.on('keypress', (str, key) => {
    if (key.ctrl && key.name === 'c') 
    {
        process.exit();
    }
    checkKey(key)
});


console.log('Premere le freciette direzionali');
console.log('^C per uscire');

var contatore:number = 0;
var contatoreSpazi:number = 0;

function checkKey(k):void {
    if (k.name == 'up') {
        contatore++;
    }
    else if (k.name == 'down'){
        contatore--;
    } 
    else if (k.name == 'right'){
        contatoreSpazi--;
    } 
    else if (k.name == 'left'){
        contatoreSpazi--;
    }
    var res:string;
    res = contatore.toString();
    for(var i = 0; i < contatoreSpazi; i++)
    {
        console.log(" ");
    }
    console.log(res);    
}
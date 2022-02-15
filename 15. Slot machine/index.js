var emoji = ["💸", "👿", "😆", "🚀"];
var rollFinito = new Event('rollFinished');
document.getElementById('container').addEventListener('rollFinished', popUp);
for(let i = 1; i <= 3; i++){
    document.getElementById("a"+i).innerHTML = emoji[Math.floor(Math.random()*4)];
    document.getElementById("c"+i).innerHTML = emoji[Math.floor(Math.random()*4)];
    document.getElementById("b"+i).innerHTML = emoji[Math.floor(Math.random()*4)];
}

async function play(){
    document.getElementById('pop-up').style.display = 'none';
    spawnRandomTimedEmoji(document.getElementById("a1"));
    spawnRandomTimedEmoji(document.getElementById("a2"));
    await spawnRandomTimedEmoji(document.getElementById("a3"));
    document.getElementById('container').dispatchEvent(rollFinito);
}
async function spawnRandomTimedEmoji(div){
    var k = 1;
    for(let i = 0; i < 1000; i += k){
        await delay(i);
        k += k/4;
        moveDown();
        div.innerHTML = emoji[Math.floor(Math.random()*4)];
    }
}
function delay(time){
    return new Promise((resolve) =>{
        setTimeout(resolve ,time);
    });
}
function moveDown(){
    for(let i = 1; i <= 3; i++){
        document.getElementById("c"+i).innerHTML = document.getElementById("b"+i).innerHTML;
        document.getElementById("b"+i).innerHTML = document.getElementById("a"+i).innerHTML;
    }   
}
function popUp(){
    document.getElementById('pop-up').innerHTML = gameResult();
    document.getElementById('pop-up').style.display = 'block';
}
function gameResult(){
    if(document.getElementById("b1").innerHTML == document.getElementById("b2").innerHTML && document.getElementById("b2").innerHTML == document.getElementById("b3").innerHTML){
        return "JACKPOT";
    }
    else if(document.getElementById("b1").innerHTML == document.getElementById("b2").innerHTML || document.getElementById("b2").innerHTML == document.getElementById("b3").innerHTML || document.getElementById("b1").innerHTML == document.getElementById("b3").innerHTML){
        return "YOU WIN";
    }
    else{
        return "YOU LOSE";
    }
}
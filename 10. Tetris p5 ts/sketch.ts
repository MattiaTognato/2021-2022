import * as p5 from 'p5';
import {} from 'p5/global';

import { Block } from './Block';
import { Griglia } from './griglia';


var grid:Griglia;
var col = 20;
var row = 10;
var widthCell = 30;
(globalThis as any).setup = function () {
    createCanvas(row * widthCell, col * widthCell);
    grid = new Griglia(col, row, widthCell);
    grid.addBlock(new Block(0, width/2/widthCell, widthCell));
    frameRate(1);
    while(grid.griglia.length < 1);
};
(globalThis as any).draw = function () {
    background(33, 66, 115);
    grid.show();

};
(globalThis as any).keyPressed = function(){
    console.log(key);
    if(key == "ArrowLeft"){
        
    }
    if(key == "ArrowRigth"){
        
    }

}

import { Block } from "./Block";
import { Cell } from "./Cell";
import { Grid } from "./grid";

export class GridMoving{
    gridMoving:Cell[][];
    col:number;
    row:number;
    wCell:number;
    blockMoving:Block;
    gridBlockStopped:Grid;

    constructor(gridBlockStopped:Grid,col:number, row:number, wCell:number){
        this.col = col;
        this.row = row;
        this.wCell = wCell;
        this.gridBlockStopped = gridBlockStopped;

        this.gridMoving = new Array<Cell[]>(this.row);
        for(var i = 0; i < this.gridMoving.length; i++){
            this.gridMoving[i] = new Array<Cell>(this.col);
        }
    }
    show(){
        for(var i = 0; i < this.row; i++){
            for(var j = 0; j < this.col; j++){
                if(this.gridMoving[i][j] != undefined || this.gridMoving[i][j] != null){
                    this.gridMoving[i][j].show();
                }
            }
        }
    }
    addBlock(block:Block){
        this.blockMoving = block;
        for(var i = 0; i < block.cells.length; i++){
            var cell = block.cells[i];
            this.gridMoving[cell.x/this.wCell][cell.y/this.wCell] = cell;
        }
    }
    movingDown():Object[]{
        if(this.blockMoving == undefined || this.blockMoving == null){
            return [null, true];
        }
        if(this.checkIfMovableDown(this.blockMoving)){
            for(var i = 0; i < this.blockMoving.cells.length; i++){
                var cell = this.blockMoving.cells[i];
                this.gridMoving[cell.x/this.wCell][cell.y/this.wCell] = null;
            }
            for(var i = 0; i < this.blockMoving.cells.length; i++){
                var cell = this.blockMoving.cells[i];
                cell.y += cell.w;
                this.gridMoving[cell.x/this.wCell][cell.y/this.wCell] = cell;
            }           
            return[null, false];
        }
        else{
            this.blockMoving.moving = false;
            var tmp = this.blockMoving;
            this.blockMoving = null;
            return [tmp, true];
        }
    }
    checkIfMovableDown(block:Block):boolean{
        for(var i = 0; i < block.cells.length; i++){
            var cell = block.cells[i];
            var nextIndex = (cell.y + cell.w)/this.wCell;
            if(cell.y + cell.w >= height || this.gridBlockStopped.grid[cell.x/this.wCell][nextIndex] != undefined || this.gridBlockStopped.grid[cell.x/this.wCell][nextIndex] != null){
                return false;
            }
        }
        return true;
    }
    moveBlock(direzione:string){
        if(this.blockMoving == undefined || this.blockMoving == null){
            return;
        }
        if(this.checkIfMovableLR(direzione, this.blockMoving)){
            for(var i = 0; i < this.blockMoving.cells.length; i++){
                var cell = this.blockMoving.cells[i];
                this.gridMoving[cell.x/this.wCell][cell.y/this.wCell] = null;       
            }
            for(var i = 0; i < this.blockMoving.cells.length; i++){
                var cell = this.blockMoving.cells[i];
                if(direzione == "right"){
                    cell.x += this.wCell;
                }
                else if(direzione == "left"){
                    cell.x -= this.wCell;
                }
                this.gridMoving[cell.x/this.wCell][cell.y/this.wCell] = cell;       
            }
        }
    }
    checkIfMovableLR(direzione:string, block:Block):boolean{
        for(var i = 0; i < block.cells.length; i++){
            var cell = block.cells[i];
            var nextIndex;
            if(direzione == "right"){   //controllo se il blocco può muoversi a destra
                nextIndex = (cell.x + cell.w)/this.wCell;
                if(nextIndex * this.wCell >= width || this.gridBlockStopped.grid[nextIndex][cell.y/this.wCell] != undefined || this.gridBlockStopped.grid[nextIndex][cell.y/this.wCell] != null){
                    return false;
                }
            }
            else if(direzione == "left"){   //controllo se il blocco può muoversi a sinistra
                nextIndex = (cell.x - cell.w)/this.wCell;
                if(nextIndex * this.wCell < 0 || this.gridBlockStopped.grid[nextIndex][cell.y/this.wCell] != undefined || this.gridBlockStopped.grid[nextIndex][cell.y/this.wCell] != null){
                    return false;
                }
            }
        }
        return true;
    }
    rotateBlock(){
        if(this.blockMoving == undefined || this.blockMoving == null){
            return;
        }
        if(this.checkIfRotatable(this.blockMoving)){
            for(var i = 0; i < this.blockMoving.cells.length; i++){
                var cell = this.blockMoving.cells[i];
                this.gridMoving[cell.x/this.wCell][cell.y/this.wCell] = null;
            }
            for(var i = 0; i < this.blockMoving.cells.length; i++){
                var cell = this.blockMoving.cells[i];
                cell.y += cell.w;
                this.gridMoving[cell.x/this.wCell][cell.y/this.wCell] = cell;
            }           
            return[null, false];
        }
    }
    checkIfRotatable(block:Block):boolean{
        var nextIndexes = block.getNextIndexOfRotate();
        for(var i = 0; i < nextIndexes.length; i++){
            var cell = block.cells[i];
            if(cell.y + cell.w >= height || cell.x * this.wCell < 0 || cell.x * this.wCell >= width || this.gridBlockStopped.grid[cell.x/this.wCell][cell.y/this.wCell] != undefined || this.gridBlockStopped.grid[cell.x/this.wCell][cell.y/this.wCell] != null){
                return false;//se il blocco sbatte giù || sinistra || destra || ci sono celle dove deve andare ritorna false
            }
        }
        return true;
    }
}
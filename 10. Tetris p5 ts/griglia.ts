import { Block } from "./Block";
import { Cell } from "./Cell";

export class Griglia{
    griglia:Cell[][];
    col:number;
    row:number;
    wCell:number;
    blockMoving:Block;
    constructor(col:number, row:number, wCell:number){
        this.griglia = new Array<Cell[]>(row);
        for(var i = 0; i < this.griglia.length; i++){
            this.griglia[i] = new Array<Cell>(col);
        }
        this.wCell = wCell;
        this.col = col;
        this.row = row;

    }
    show(){
       
        for(var i = this.row-1; i >= 0 ; i--){      //scorre tutta la griglia
            for(var j = this.col-1; j >= 0; j--){
                if(this.griglia[i][j] == undefined)
                {
                    stroke(148, 140, 117);
                    noFill();
                    strokeWeight(1);
                    rect(i * this.wCell, j * this.wCell, this.wCell, this.wCell);   //se non c'è niente disegna il quadratino
                }
                else
                {
                    if(this.griglia[i][j].moving != false){
                        this.updateCell(this.griglia[i][j]);
                    }
                    fill(116, 173, 0);
                    rect(i * this.wCell, j * this.wCell, this.wCell, this.wCell)
                }
            }
        }
        //this.updateGrid();
    }
    addBlock(block:Block){
        this.blockMoving = block;
        for(var i = 0; i < block.cells.length; i++){
            var cell = block.cells[i];
            this.griglia[cell.x/this.wCell][cell.y/this.wCell] = cell;
        }
    }
    updateGrid()
    {
        var tmp = this.griglia;         
        this.griglia = new Array<Cell[]>(this.row);     //nuova griglia
        for(var i = 0; i < this.griglia.length; i++){
            this.griglia[i] = new Array<Cell>(this.col);
        }
        for(var i = 0; i < this.row; i++){      //scorre tutta la griglia
            for(var j = 0; j < this.col; j++){
                if(tmp[i][j] != undefined){     //se c'è una cella nella griglia vecchia
                    this.griglia[tmp[i][j].x/this.wCell][tmp[i][j].y/this.wCell] = tmp[i][j]; //mettila nella griglia nuova nella posizione giusta
                }
            }
        }
    }
    updateCell(cell:Cell){
        var nextIndex = (cell.y + cell.w)/this.wCell;
        if(cell.y + cell.w >= height || (this.griglia[cell.x/this.wCell][nextIndex] != undefined && this.griglia[cell.x/this.wCell][nextIndex].moving == false)){
            cell.moving = false;
            return;
        }
        this.griglia[cell.x/this.wCell][cell.y/this.wCell] = null;
        cell.y += cell.w;
        this.griglia[cell.x/this.wCell][cell.y/this.wCell] = cell;
    }
    moveBlock(n){
        for(var i = 0; i < this.blockMoving.cells.length; i++){
            
        }
    }
}
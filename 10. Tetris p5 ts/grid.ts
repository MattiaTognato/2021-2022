import { Block } from "./Block";
import { Cell } from "./Cell";

export class Grid{
    col:number;
    row:number;
    wCell:number;
    grid:Cell[][];
    constructor(col:number, row:number, wCell:number){
        this.col = col;
        this.row = row;
        this.wCell = wCell;
        this.grid = new Array<Cell[]>(row);
        for(var i = 0; i < this.grid.length; i++){
            this.grid[i] = new Array<Cell>(col);
        }
    }
    show(){
        for(var i = 0; i < this.row; i++){
            for(var j = 0; j < this.col; j++){
                if(this.grid[i][j] != undefined && this.grid[i][j] != null){
                    noStroke();
                    fill(54, 117, 106);
                    rect(i * this.wCell, j * this.wCell, this.wCell, this.wCell);   //se c'è un blocco fermo disegnalo
                }
                else
                {
                    stroke(148, 140, 117);
                    noFill();
                    strokeWeight(1);
                    rect(i * this.wCell, j * this.wCell, this.wCell, this.wCell);   //se non c'è niente disegna il quadratino
                }
            }
        }
    }
    addBlock(block:Block){
        for(var i = 0; i < block.cells.length; i++){
            var cell = block.cells[i];
            this.grid[cell.x/this.wCell][cell.y/this.wCell] = cell;
        }
    }
}
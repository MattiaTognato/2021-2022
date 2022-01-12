import { Cell } from "./Cell";

export class Block{
    cells:Cell[];

    constructor(typeOfBlock:number, spawnX:number, wCell:number){
        this.cells = [];

        switch(typeOfBlock){
            case 0:// caso I
                for(var i = 0; i < 4; i++){
                    this.cells.push(new Cell(spawnX, i, wCell));
                }
                break;
            case 1:// caso J
                for(var i = 0; i < 3; i++){
                    this.cells.push(new Cell(spawnX, i, wCell));
                }
                this.cells.push(new Cell(spawnX + 1, 2, wCell));
                break;



        }
    }
}
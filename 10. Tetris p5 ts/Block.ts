import { Cell } from "./Cell";

export class Block{
    cells:Cell[];
    typeOfBlock:number;
    private _moving:boolean;
    
    get moving():boolean{
        return this._moving;
    }
    set moving(value:boolean){
        this._moving = value;
        for(var i = 0; i < this.cells.length; i++){
            this.cells[i].moving = value;   //setta tutte le celle del blocco in movimento con moving = value
        }
    }

    constructor(typeOfBlock:number, spawnX:number, wCell:number){
        this.cells = [];
        this.typeOfBlock = typeOfBlock;
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
                this.cells.push(new Cell(spawnX - 1, 2, wCell));
                break;
            case 2:// caso L
                for(var i = 0; i < 3; i++){
                    this.cells.push(new Cell(spawnX, i, wCell));
                }
                this.cells.push(new Cell(spawnX + 1, 2, wCell));
                break;
            case 3:// caso S
                this.cells.push(new Cell(spawnX, 0, wCell));
                this.cells.push(new Cell(spawnX, 1, wCell));
                this.cells.push(new Cell(spawnX + 1, 1, wCell));
                this.cells.push(new Cell(spawnX + 1, 2, wCell));
                break;
            case 4:// caso Z
                this.cells.push(new Cell(spawnX + 1, 0, wCell));
                this.cells.push(new Cell(spawnX + 1, 1, wCell));
                this.cells.push(new Cell(spawnX, 1, wCell));
                this.cells.push(new Cell(spawnX, 2, wCell));
                break;
            case 5:// caso T
                this.cells.push(new Cell(spawnX - 1, 0, wCell));
                this.cells.push(new Cell(spawnX, 0, wCell));
                this.cells.push(new Cell(spawnX + 1, 0, wCell));
                this.cells.push(new Cell(spawnX, 1, wCell));
                break;
            case 6:// caso O
                this.cells.push(new Cell(spawnX + 1, 0, wCell));
                this.cells.push(new Cell(spawnX, 0, wCell));
                this.cells.push(new Cell(spawnX + 1, 1, wCell));
                this.cells.push(new Cell(spawnX, 1, wCell));
                break;

        }
        this.moving = true;
    }
    getNextIndexOfRotate():Cell[]{
        switch(this.typeOfBlock){
            case 0:// caso I
                for(var i = 0; i < this.cells.length; i++){

                }
                break;
            case 1:// caso J
                
                break;
            case 2:// caso L
                
                break;
            case 3:// caso S
                
                break;
            case 4:// caso Z
                
                break;
            case 5:// caso T
                
                break;
            case 6:// caso O
                
                break;

        }
        return new Array<Cell>(1);
    }
}
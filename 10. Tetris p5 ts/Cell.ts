import { Block } from "./Block";

export class Cell{
    public x:number;
    public y:number;
    public w:number;
    public moving:boolean;
    
    constructor(x:number, y:number, w:number){
        this.x = x*w;
        this.y = y*w;
        this.w = w;
    }
    show() {
        fill(0);
        rect(this.x, this.y, this.w, this.w);
    }
}

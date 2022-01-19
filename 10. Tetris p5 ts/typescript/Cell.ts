export class Cell{
    public x:number;
    public y:number;
    public w:number;
    public moving:boolean;
    private _color:string;
    
    constructor(x:number, y:number, w:number, c:string){
        this.x = x*w;
        this.y = y*w;
        this.w = w;
        this._color = c;
    }
    
    show() {
        fill(this._color);
        rect(this.x, this.y, this.w, this.w);
    }
}

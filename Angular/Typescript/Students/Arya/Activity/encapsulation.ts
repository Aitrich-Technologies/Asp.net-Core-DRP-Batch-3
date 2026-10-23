class Students {
  private _marks: number = 0;

  get marks(): number {
    return this._marks;
  }

  set marks(value: number) {
    if (value >= 0 && value <= 100) {
      this._marks = value;
    } else {
      console.log("Invalid marks!");
    }
  }
}

const s1 = new Students();

s1.marks = 90;                
console.log(s1.marks);         
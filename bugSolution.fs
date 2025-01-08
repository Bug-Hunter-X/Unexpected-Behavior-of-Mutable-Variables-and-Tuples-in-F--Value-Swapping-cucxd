let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20

//Correct way to swap values using tuples
let swapTuple (x,y) = 
    let x1 = y
    let y1 = x
    (x1,y1)
let (x,y) = swapTuple (x,y)
printf "%d %d" x y //This will print 20 10 
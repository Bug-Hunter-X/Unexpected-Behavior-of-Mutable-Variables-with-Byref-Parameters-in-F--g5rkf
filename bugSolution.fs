let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 10 which is the correct swapping

//However, if we do the following:
let mutable a = 10
let mutable b = 20

let swap2 (x:byref<int>) (y:byref<int>) = 
    let temp = !x
    x <- &y
    y <- &temp

swap2 &a &b
printf "%d %d" a b // This will print 20 10 which is the correct swapping

//Correct way of swapping two variables using byref parameters in F#:
let mutable a = 10
let mutable b = 20

let swap3 (x:byref<int>) (y:byref<int>) = 
    let temp = !x
    x <- !y
    y <- &temp

swap3 &a &b
printf "%d %d" a b //This will print 20 10 which is the correct swapping
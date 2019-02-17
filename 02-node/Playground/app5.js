const sub_fib = (x, a, b) => x > 0 ? sub_fib(x-1, b, a+b) : a
const fib = (x) => sub_fib(x, 0,1)

fib(0);
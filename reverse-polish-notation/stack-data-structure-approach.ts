function evalRPN(tokens: string[]): number {
    const stack: number[] = []

    for (let i = 0; i < tokens.length; i++) {
        if (tokens[i] === "+") {
            stack.push(stack.pop()! + stack.pop()!)
        } else if (tokens[i] === "*") {
            stack.push(stack.pop()! * stack.pop()!)
        } else if (tokens[i] === "-") {
            const [num2, num1] = [stack.pop()!, stack.pop()!]
            stack.push(num1 - num2)
        } else if (tokens[i] === "/") {
            const [num2, num1] = [stack.pop()!, stack.pop()!]
            let division = Math.trunc(num1 / num2)
            stack.push(division)
        } else {
            stack.push(Number(tokens[i]))
        }
    }

    return stack[0]
};

function groupAnagrams(strs: string[]): string[][] {
    const result = new Map<string, string[]>([])

    strs.forEach((str: string) => {
        const sortedStr = str.split("").sort().toString()
        if (result.get(sortedStr)) {
            result.set(sortedStr, [...result.get(sortedStr)!, str])
        } else {
            result.set(sortedStr, [str])
        }
    })

    return [...result.values()]
};

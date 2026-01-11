const getSignature = (s: string) => {
    const letterCounter = Array(26).fill(0);
    for (const char of s) {
        letterCounter[char.charCodeAt(0) - 'a'.charCodeAt(0)]++;
    }

    const letterCounterResult = [];
    for (let i = 0; i < 26; i++) {
        if (letterCounter[i] !== 0) {
            letterCounterResult.push(String.fromCharCode(i + 'a'.charCodeAt(0)), letterCounter[i].toString())
        }
    }

    return letterCounterResult.join('');
};

const groupAnagrams = (strs: string[]) => {
    const groups = new Map<string, string[]>();

    for (const s of strs) {
        const signature = getSignature(s);
        console.log(signature)
        if (!groups.has(signature)) {
            groups.set(signature, []);
        }
        groups.get(signature)?.push(s);
    }

    return [...groups.values()];
};

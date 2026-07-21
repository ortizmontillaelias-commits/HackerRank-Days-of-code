function processData(input) {
    //Enter your code here
    const lines = input.split('\n');
    const n = parseInt(lines[0]);
    
    const phoneBook = {};
    for (let i = 1; i <= n; i++) {
        const [name, number] = lines[i].split(' ');
        phoneBook[name] = number;
    }
    
    let output = [];
    for (let i = n + 1; i < lines.length; i++) {
        const name = lines[i].trim();
        if (name === '') continue;
        if (phoneBook.hasOwnProperty(name)) {
            output.push(`${name}=${phoneBook[name]}`);
        } else {
            output.push('Not found');
        }
    }
    
    console.log(output.join('\n'));
} 

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
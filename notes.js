let j = 2;
for (let i = 1, let count = 1; i < 100; i = i * 2, count++) {
	j = j - 1;
	while(j < 25) {
		j = j + 5;
		console.log(j);
	}
    console.log("итерация номер: " + count);
}
// 2,4,8,16,32,64
// 6,11,16,21,26
//
// 29
let p = 2;
for (let q = 2; q < 32; q = q * 2) {
	while (p < q) {
		p = p * 2;
		console.log(p);
	}
	q = p - q;
}
// q = 0
// q = 2
// p = 4; q = 0
// q = 4
// p = 8; q = 0
// q = 8
// p = 16; q = 0
// q = 16


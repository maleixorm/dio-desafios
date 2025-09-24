const valorSalario = 2000;
const valorBeneficios = 250;

const valorImposto = calcularImposto(valorSalario);

const saida = valorSalario - valorImposto + valorBeneficios;
console.log(saida.toFixed(2));

function calcularImposto(salario) {
    let aliquota;
    if (salario >= 0 && salario <= 1100) {
        aliquota = 0.05;
    } else if (salario >= 1100.01 && salario <= 2500) {
        aliquota = 0.10;
    } else {
        aliquota = 0.15;
    }
    return aliquota * salario;
}
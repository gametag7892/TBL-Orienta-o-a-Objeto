// 6. Explique por que numeros1[0] foi alterado.
// R: Atribuir numeros1 a numeros2 faz com que ambas as variáveis apontem para o mesmo array na memória. Portanto, modificar numeros2 também afeta numeros1.

// Como evitar que numeros1 seja modificado ao alterar numeros2?
// R: Para evitar isso, você pode criar uma cópia do array original usando o método Array.Copy
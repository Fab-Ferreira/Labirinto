# Labirinto
## Introdução
Olá! Este programa é um joguinho de labirinto bem simples na qual utilizar o teclado do computador para se locomover até o final do labirinto. O programa a seguir foi feito no SharpDevelop utilizando o Windows Application.
&nbsp;

## Funcionalidade do Programa
O usuário inicia o labirinto sendo o quadrado azul no canto superior esquerdo da tela. Utilizando as teclas W, A, S e D, o usuário deve ser mover até o quadrado verde. Para isso, as portas (retangulos em vermelho) devem ser abertas através dos quadrados amarelos. O programa conta com um Timer que calcula em quanto tempo (em segundos) o usuário conseguiu chegar até o final do labirinto, sendo iniciado após o usuário clicar em qualquer tecla do teclado. Caso queira reiniciar o jogo, apenas clique no botão Reiniciar que está na tela.

#### Como Funciona a Colisão das "Paredes Brancas"?
As paredes brancas na tela, na verdade, são Picture Boxes sem imagens e com cor de fundo branca. O programa observa se o usuário, após pressionar uma das quatro teclas de movimento, se ele entrou dentro da PictureBox branca. Levando em conta que o quadrado azul se move 40 pixels para os quatro lados, se ele entrar na parede branca e o usuário tivesse pressionado:
- **A tecla W**, ou seja, para cima, o quadrado azul irá se mover 40 pixels para baixo;
- **A tecla A**, ou seja, para a esquerda, o quadrado azul irá se mover 40 pixels para a direita;
- **A tecla S**, ou seja, para baixo, o quadrado azul irá se mover 40 pixels para cima;
- **A tecla D**, ou seja, para a direita, o quadrado azul irá se mover 40 pixels para a esquerda;

Basicamente, o quadrado azul fica dentro da parede branca, porém instantâneamente acaba retornando à sua posição original, dando esse efeito de colisão.

Este é o meu programa, espero que tenha gostado e que a explicação tenha sido eficiente. No próprio código, há alguns comentários explicando as linhas para caso queira entender melhor.

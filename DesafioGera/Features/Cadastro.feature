#language: pt-BR
#encoding: utf-8

Funcionalidade: Cadastro
	Como cliente não cadastrado
	Eu desejo criar um novo cadastro
	Para conseguir acessar a loja virtual

Contexto: Acesso ao site
	Dado que acesso o site de compras

	Cenário: Cadastro pessoa física com dados válidos
		Dado que preencho o e-mail
		| Email               |
		| ryukiharu@gmail.com |
		E informo que essa é minha primeira compra
		Quando clico em continuar
		Então vejo a tela de cadastro
		Quando preencho os campos obrigatório e salvar
		| Nome            | CPF         | DDDTelefone | Telefone | DDDCelular | Celular   | DiaNasc | MesNasc | AnoNasc | Email               | Senha    | Genero |
		| Rafael Yamagawa | 43074803843 | 19          | 32812289 | 19         | 994471412 | 17      | 08      | 1994    | ryukiharu@gmail.com | Asdf1234 | M      |
		Então vejo o meu carrinho de compras

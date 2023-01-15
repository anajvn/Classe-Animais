# Treinando interfaces com Animais

Dadas as classes base no diagrama abaixo, criar as classes para os seguintes animais: leão, chacal, morcego, cisne, arara, dragão de comodo, lontra, pinguim, coruja, elefante e jacaré. Deve estar adequado também o cadastro de um ornitorrinco.

Lembre-se de verificar as características de cada animal, por exemplo, um réptil que seja aquático E terrestre, etc.

Classe Animal
* String Nome
* DateTime Data de Nascimento
* Char Sexo
* Int Idade
* Bool Carnivoro
* Bool Peçonhento
* Void Movimentar()
* Void Comunicar()
* Void Alimentar()

Classe Mamífero
* Int Quantidade de mamas
* Bool Pelos
* String Cor do Pelo
* Void Amamentar()

Classe Ave
* Bool Rapina
* String Cor da Pena
* Void Ciscar()

Classe Reptil
* Bool TemEscamas
* Bool TemCasco

Interface IOviparo
* Void Botar()
* Void Chocar()

Interface IVoar
* Int AltitudeMaximaEmMetros
* Double VelocidadeDoVoo
* Void Voar()

Interface IAquatico
* Bool ViveEmTerra
* Bool Mergulho
* Bool AguaDoce




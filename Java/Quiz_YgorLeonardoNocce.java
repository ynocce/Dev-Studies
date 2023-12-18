import java.util.Scanner;

public class Quiz_YgorLeonardoNocce {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int ponto = 0;
		int quest = 0;
		String resposta;
		
		System.out.println("----------------------------");
		System.out.println("|      Quiz Magnifico!     |");
		System.out.println("----------------------------");
		System.out.println("");
		System.out.println("Como jogar?");
		System.out.println("");
		System.out.println("Apenas digite a alternativa da resposta.");
		System.out.println("");
		System.out.println("Exemplo: A, B, C ou D. Aperte enter.");
		System.out.println("");
		System.out.print("Digite seu nome: ");
		String nome = sc.next();
		System.out.println("\n");
		
		
		
///////////////////////////////////////////////////////////////////////////////////////////////////////////			
		
		
		
		System.out.println("-------------------------------------------------");
		System.out.println("Nome: " + nome + " | pontos " + ponto + " | Dificuldade: Fácil" );
		System.out.println("");
		System.out.println("1- De quem é a famosa frase “Penso, logo existo”?");
		System.out.println("-------------------------------------------------");
		System.out.println("A) Platão\r\n"
				+ "B) Galileu Galilei\r\n"
				+ "C) Descartes\r\n"
				+ "D) Sócrates");
		System.out.println("-------------------------------------------------");
		System.out.print("Digite a resposta: ");
		resposta = sc.next();
		if (resposta.equalsIgnoreCase("c")) { 
			System.out.println("* Você Acertou *");
			ponto = ponto + 10;
			quest = quest + 1;
		}
		else {
			System.out.println("# Você Errou #");
		}
		System.out.print("");
		System.out.println("-------------------------------------------------");
		
		System.out.println("\n\n");				
		
		
///////////////////////////////////////////////////////////////////////////////////////////////////////////		
		
		
		System.out.println("-------------------------------------------------");
		System.out.println("Nome: " + nome + " | pontos " + ponto + " | Dificuldade: Fácil" );
		System.out.println("");
		System.out.println("2- De onde é a invenção do chuveiro elétrico?");
		System.out.println("-------------------------------------------------");
		System.out.println("A) França\r\n"
				+ "B) Inglaterra\r\n"
				+ "C) Austrália\r\n"
				+ "D) Brasil");
		System.out.println("-------------------------------------------------");
		System.out.print("Digite a resposta: ");
		resposta = sc.next();
		if (resposta.equalsIgnoreCase("d")) { 
			System.out.println("* Você Acertou *");
			ponto = ponto + 10;
			quest = quest + 1;
		}
		else {
			System.out.println("# Você Errou #");
		}
		System.out.print("");
		System.out.print("-------------------------------------------------");
		
		System.out.println("\n\n");		
		
		
///////////////////////////////////////////////////////////////////////////////////////////////////////////	
		
		
		System.out.println("-------------------------------------------------");
		System.out.println("Nome: " + nome + " | pontos " + ponto + " | Dificuldade: Fácil" );
		System.out.println("");
		System.out.println("3- Qual o livro mais vendido no mundo a seguir à Bíblia?");
		System.out.println("-------------------------------------------------");
		System.out.println("A) O Senhor dos Anéis\r\n"
				+ "B) Dom Quixote\r\n"
				+ "C) O Pequeno Príncipe\r\n"
				+ "D) Ela, a Feiticeira");
		System.out.println("-------------------------------------------------");
		System.out.print("Digite a resposta: ");
		resposta = sc.next();
		if (resposta.equalsIgnoreCase("b")) { 
			System.out.println("* Você Acertou *");
			ponto = ponto + 10;
			quest = quest + 1;
		}
		else {
			System.out.println("# Você Errou #");
		}
		System.out.print("");
		System.out.print("-------------------------------------------------");
		
		System.out.println("\n\n");		
	
		
///////////////////////////////////////////////////////////////////////////////////////////////////////////	
		
		
		System.out.println("-------------------------------------------------");
		System.out.println("Nome: " + nome + " | pontos " + ponto + " | Dificuldade: Fácil" );
		System.out.println("");
		System.out.println("4- O que a palavra legend significa em português?");
		System.out.println("-------------------------------------------------");
		System.out.println("A) Lenda\r\n"
				+ "B) Conto\r\n"
				+ "C) História\r\n"
				+ "D) Legenda");
		System.out.println("-------------------------------------------------");
		System.out.print("Digite a resposta: ");
		resposta = sc.next();
		if (resposta.equalsIgnoreCase("a")) { 
			System.out.println("* Você Acertou *");
			ponto = ponto + 10;
			quest = quest + 1;
		}
		else {
			System.out.println("# Você Errou #");
		}
		System.out.print("");
		System.out.print("-------------------------------------------------");
		
		System.out.println("\n\n");	
		
		
///////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		if (ponto <= 20) {
			System.out.println("Olá, " + nome + ", você acertou apenas " + quest + 
								" questões e fez " + ponto + " Pontos.");
			System.out.println("");
			System.out.println("Tente novamente!!!");
			System.out.println("");
			System.out.println("Fim de jogo...");
			System.out.println("\n");
			System.out.println("-------------------------------------------------");
			System.out.println("\n\n");
			System.exit(0);
			
		}
		else {
			System.out.println("Parabens " + nome + " você acertou " + quest + " Questões!");
			System.out.println("");
			System.out.println("Você marcou " + ponto + " Pontos!");
			System.out.println("");
			System.out.println("Você passou para a proxima dificuldade: Média");
			System.out.println("\n");
		}

///////////////////////////////////////////////////////////////////////////////////////////////////////////	
		
		
		System.out.println("-------------------------------------------------");
		System.out.println("Nome: " + nome + " | pontos " + ponto + " | Dificuldade: Média");
		System.out.println("");
		System.out.println("5- Qual o número mínimo de jogadores numa partida de futebol?");
		System.out.println("-------------------------------------------------");
		System.out.println("A) 5\r\n"
					+ "B) 6\r\n"
					+ "C) 7\r\n"
					+ "D) 8");
		System.out.println("-------------------------------------------------");
		System.out.print("Digite a resposta: ");
		resposta = sc.next();
		if (resposta.equalsIgnoreCase("c")) {
			System.out.println("* Você Acertou *");
			ponto = ponto + 10;
			quest = quest + 1;
		} else {
			System.out.println("# Você Errou #");
		}
		System.out.print("");
		System.out.print("-------------------------------------------------");

		System.out.println("\n\n");	
		
		
///////////////////////////////////////////////////////////////////////////////////////////////////////////	
		
		
		System.out.println("-------------------------------------------------");
		System.out.println("Nome: " + nome + " | pontos " + ponto + " | Dificuldade: Média");
		System.out.println("");
		System.out.println("6- Em que período da pré-história o fogo foi descoberto?");
		System.out.println("-------------------------------------------------");
		System.out.println("A) Neolítico\r\n"
					+ "B) Paleolítico\r\n"
					+ "C) Idade dos Metais\r\n"
					+ "D) Período da Pedra Polida");
		System.out.println("-------------------------------------------------");
		System.out.print("Digite a resposta: ");
		resposta = sc.next();
		if (resposta.equalsIgnoreCase("b")) {
			System.out.println("* Você Acertou *");
			ponto = ponto + 10;
			quest = quest + 1;
		} else {
			System.out.println("# Você Errou #");
		}
		System.out.print("");
		System.out.print("-------------------------------------------------");

		System.out.println("\n\n");
		
///////////////////////////////////////////////////////////////////////////////////////////////////////////	
		
		System.out.println("-------------------------------------------------");
		System.out.println("Nome: " + nome + " | pontos " + ponto + " | Dificuldade: Média");
		System.out.println("");
		System.out.println("7- Quanto tempo a luz do Sol demora para chegar à Terra?");
		System.out.println("-------------------------------------------------");
		System.out.println("A) 12 minutos\r\n"
						+ "B) 1 dia\r\n"
						+ "C) 12 horas\r\n"
						+ "D) 8 minutos");
		System.out.println("-------------------------------------------------");
		System.out.print("Digite a resposta: ");
		resposta = sc.next();
		if (resposta.equalsIgnoreCase("d")) {
			System.out.println("* Você Acertou *");
			ponto = ponto + 10;
			quest = quest + 1;
		} else {
			System.out.println("# Você Errou #");
		}
		System.out.print("");
		System.out.print("-------------------------------------------------");

		System.out.println("\n\n");

		
///////////////////////////////////////////////////////////////////////////////////////////////////////////	
		
		
		if (ponto <= 40) {
			System.out.println("Olá, " + nome + ", você acertou apenas " + quest + 
								" questões e fez " + ponto + " Pontos.");
			System.out.println("");
			System.out.println("Tente novamente!!!");
			System.out.println("");
			System.out.println("Fim de jogo...");
			System.out.println("\n");
			System.out.println("-------------------------------------------------");
			System.out.println("\n\n");
			System.exit(0);
			
		}
		else {
			System.out.println("Parabens " + nome + " você acertou " + quest + " Questões!");
			System.out.println("");
			System.out.println("Você marcou " + ponto + " Pontos!");
			System.out.println("");
			System.out.println("Você passou para a proxima dificuldade: Difícil");
			System.out.println("\n");
		}
		
		
///////////////////////////////////////////////////////////////////////////////////////////////////////////	
		
		System.out.println("-------------------------------------------------");
		System.out.println("Nome: " + nome + " | pontos " + ponto + " | Dificuldade: Difícil");
		System.out.println("");
		System.out.println("8- Qual a velocidade da luz?");
		System.out.println("-------------------------------------------------");
		System.out.println("A) 300 000 000 metros por segundo (m/s)\r\n"
				+ "B) 150 000 000 metros por segundo (m/s)\r\n"
				+ "c) 199 792 458 metros por segundo (m/s)\r\n"
				+ "D) 299 792 458 metros por segundo (m/s)\r\n");
		System.out.println("-------------------------------------------------");
		System.out.print("Digite a resposta: ");
		resposta = sc.next();
		if (resposta.equalsIgnoreCase("d")) {
			System.out.println("* Você Acertou *");
			ponto = ponto + 10;
			quest = quest + 1;
		} else {
			System.out.println("# Você Errou #");
		}
		System.out.print("");
		System.out.print("-------------------------------------------------");

		System.out.println("\n\n");
		
///////////////////////////////////////////////////////////////////////////////////////////////////////////	
		
		System.out.println("-------------------------------------------------");
		System.out.println("Nome: " + nome + " | pontos " + ponto + " | Dificuldade: Difícil");
		System.out.println("");
		System.out.println("9- Júpiter e Plutão são os correlatos romanos de quais deuses gregos?");
		System.out.println("-------------------------------------------------");
		System.out.println("A) Ares e Hermes\r\n"
				+ "B) Cronos e Apolo\r\n"
				+ "C) Zeus e Hades\r\n"
				+ "D) Dionísio e Deméter");
		System.out.println("-------------------------------------------------");
		System.out.print("Digite a resposta: ");
		resposta = sc.next();
		if (resposta.equalsIgnoreCase("c")) {
			System.out.println("* Você Acertou *");
			ponto = ponto + 10;
			quest = quest + 1;
		} else {
			System.out.println("# Você Errou #");
		}
		System.out.print("");
		System.out.print("-------------------------------------------------");

		System.out.println("\n\n");

///////////////////////////////////////////////////////////////////////////////////////////////////////////	

		System.out.println("-------------------------------------------------");
		System.out.println("Nome: " + nome + " | pontos " + ponto + " | Dificuldade: Difícil");
		System.out.println("");
		System.out.println("10- Qual o metal cujo símbolo químico é o Au?");
		System.out.println("-------------------------------------------------");
		System.out.println("A) Cobre\r\n"
				+ "B) Prata\r\n"
				+ "C) Mercúrio\r\n"
				+ "D) Ouro");
		System.out.println("-------------------------------------------------");
		System.out.print("Digite a resposta: ");
		resposta = sc.next();
		if (resposta.equalsIgnoreCase("d")) {
			System.out.println("* Você Acertou *");
			ponto = ponto + 10;
			quest = quest + 1;
		} else {
			System.out.println("# Você Errou #");
		}
		System.out.print("");
		System.out.print("-------------------------------------------------");

		System.out.println("\n\n");
		
///////////////////////////////////////////////////////////////////////////////////////////////////////////	
		
		
		System.out.print("-------------------------------------------------");
		System.out.println("\n");
		System.out.println("Parabéns " + nome + " você terminou o Quiz Magnifico!");
		System.out.println("");
		System.out.println("Seus pontos: " + ponto);
		System.out.println("Quantidade de questões: 10");
		System.out.println("Qauantidades de acertos: " + quest);
		System.out.println("");
		System.out.println("Parabéns por chegar até aqui!!!");
		System.out.println("");
		System.out.println("Fim de jogo...");
		System.out.println("\n");
		System.out.println("-------------------------------------------------");
		System.out.println("\n\n");
		System.exit(0);
		
		sc.close();
	}	
}

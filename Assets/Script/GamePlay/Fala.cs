using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Fala : MonoBehaviour {

    public Text fala = null;
	public int contador = 0;

    public void Next()
    {
        contador++;
		if (contador == 1) {
			fala.text = "E essa cidade era o lar de Aisha Hadiya, uma mulher de familia rica e importante, casada com um militar e deste bom casamento se tinha seus tres filhos.";
		} else if (contador == 2) {
			fala.text = "Sobrevivendo sozinha por meses, em julho de 2012 Aisha encontra Hana Madihah vagando desnorteada ao redor dos escombros de uma escola. A menina estava assustada e machucada, Aisha a ajudou e juntas continuaram a jornada de sobrevivencia. ";
		} else if (contador == 3) {
			fala.text = "Duas semanas depois, elas encontram Jamal e Mustafa andando perto de um hospital buscando medicamentos. Jamal conta a Aisha que conheceu pessoas que estava indo para Alepo para atravessar a fronteira e irem para a Turquia, ela ve nisso uma oportunidade de irem para um local seguro onde todos poderiam recomeçar suas vidas. \n";
		} else if (contador == 4) {
			fala.text = "Mas antes eles terão que encontrar suprimentos necessarios para sobreviver durante a travessia, pegue todos os itens necessários e va para a próxima etapa. \n";
		}
			else if (contador == 5) {
			SceneManager.LoadScene ("Arcade");
		}
    }
}

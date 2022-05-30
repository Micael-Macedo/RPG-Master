function CalcularAtributo(dado, atributo){
    dadoElement = document.getElementById(dado).value;
    modificador = document.getElementById(atributo).value;
    modificador = (dadoElement -10)/2;
    modficadorInt = parseInt(modificador);
    if(modificador / modficadorInt != 1 && modificador != 0){
        modificador -= 0.5;
    }
    document.getElementById(atributo).innerHTML = modificador;
}

function rolarDado(atributo,min,max){
    modificador = document.getElementById(atributo).innerHTML
    modificadorInt = parseInt(modificador)
    dado = Math.floor(Math.random() * max)+min;
    if(dado == 20){
        alert("CRITICO"); //pode servir para criar uma função para avisar quando dar Crítico
    }
    rolagem =  dado + modificadorInt;
    alert(dado + "+ " + modificadorInt + "= " + rolagem);
}
function tocaSom(idElementoAudio) {
    const elemento = document.querySelector(idElementoAudio);

    if(elemento && elemento.localName === 'audio'){
        elemento.play();
    }
    else {
        console.log('Elemento não encontrado ou seletor inválido');
    }
}

const listaTeclas = document.querySelectorAll('.tecla');

for(let contador = 0; contador < listaTeclas.length; contador++) {

    const tecla = listaTeclas[contador];
    const instrumento = tecla.classList[1];

    // template string
    const idAudio = `#som_${instrumento}`;

    tecla.onclick = function () {
        tocaSom(idAudio);
    }

    tecla.onkeydown = function (evento) {
        if(evento.code === 'Space' || evento.code === 'Enter') {
            tecla.classList.add('ativa');
        }
    }

    tecla.onkeyup = function () {
        tecla.classList.remove('ativa');
    }
}

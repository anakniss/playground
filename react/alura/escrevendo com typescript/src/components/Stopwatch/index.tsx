import Button from '../Button';
import Watch from './Watch';
import style from './Stopwatch.module.scss';
import { tempoParaSegundos } from '../../common/utils/time';
import { ITarefa } from '../../types/ITarefa';
import { useEffect, useState } from 'react';

interface Props {
    selecionado: ITarefa | undefined;
    finalizarTarefa: () => void;
}

export default function Stopwatch( { selecionado, finalizarTarefa } : Props ){
    const [tempo, setTempo] = useState<number>();
    useEffect(() => {
        if(selecionado?.tempo) {
            setTempo(tempoParaSegundos(selecionado.tempo))
        }

    }, [selecionado])

    function regressiva(contador: number = 0){
        setTimeout(() => {
            if(contador > 0) {
                setTempo(contador - 1);
                return regressiva(contador - 1);
            }
            finalizarTarefa();
        }, 1000 )
    }
    return(
        <div className={style.stopwatch}>
            <p className={style.titulo}>Escolha um card e inicie o cronômetro</p> 
            <div className={style.relogioWrapper}>
                <Watch tempo={tempo} />
            </div>
            <Button onClick={() => regressiva(tempo)}>
                Começar!
            </Button>
        </div>
    )
}
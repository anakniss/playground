import Button from '../Button';
import Watch from './Watch';
import style from './Stopwatch.module.scss'

export default function Stopwatch(){
    return(
        <div className={style.stopwatch}>
            <p className={style.titulo}>Escolha um card e inicie o cronometro</p>
            <div className={style.relogioWrapper}>
                <Watch />
            </div>
            <Button>
                Começar!
            </Button>
        </div>
    )
}
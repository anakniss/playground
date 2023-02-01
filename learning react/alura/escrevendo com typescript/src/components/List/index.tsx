import style from './List.module.scss';
import Item from './Item'
import { ITarefa } from '../../types/ITarefa';

interface Props {
    tarefas:ITarefa[]
    selecionaTarefa: (tarefaSelecionada: ITarefa) => void
}

function List({ tarefas, selecionaTarefa } : Props) {
    
    return (
        <aside className={style.listaTarefas}>
        <h2></h2>
            <ul>
                {tarefas.map((item, index) => (
                    <Item
                        key={item.id}
                        {...item}
                        selecionaTarefa={selecionaTarefa}
                    />
                ))}
            </ul>
        </aside>
    )
}

export default List;
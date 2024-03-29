import React, { useState } from 'react';
import Form from '../components/Form';
import List from '../components/List';
import { ITarefa } from '../types/ITarefa';
import style from './App.module.scss';
import Stopwatch from '../components/Stopwatch';

function App() {
  const [tarefas, setTarefas] = useState<ITarefa[]>([]);
  const [selecionado, setSelecionado] = useState<ITarefa>();

  function selecionaTarefa(tarefaSelecionada: ITarefa){
    setSelecionado(tarefaSelecionada);
    setTarefas(tarefasAnteriores => tarefasAnteriores.map(tarefa => ({
      ...tarefa,
      selecionado: tarefa.id === tarefaSelecionada.id ? true : false
    })) )
  }

  function finalizarTarefa() {
    if(selecionado){
      setSelecionado(undefined);
      setTarefas(tarefasAnteriores => tarefasAnteriores.map(tarefa => {
        if(tarefa.id === selecionado.id) {
          return {
            ...tarefa,
            selecionado: false,
            completado: true
          }
        }
        return tarefa;
      }))
    }
  }

  return (
    <div className={style.AppStyle}>
      <Form setTarefas={setTarefas} />
      <List 
      tarefas={tarefas}
      selecionaTarefa={selecionaTarefa}
      />
      <Stopwatch 
      selecionado={selecionado} 
      finalizarTarefa={finalizarTarefa}
      />
    </div>
  );
}

export default App;
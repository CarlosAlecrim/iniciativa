import React,{Compontent} from "react";

class FormEvento extends React.Component{
    constructor(){
        super();
    }

    render(){
        return(
            <div>
            <h1>Cadastrar Evento</h1>
            <form>
                <div className="form-group">
                <label >Nome</label>
                <input type="text" name="nome" className="form-control" placeholder="Nome"></input>
                </div>
                <div className="form-group">
                <label>Descrição</label>
                <input type="text" name="descricao" className="form-control" placeholder="Descrição"></input>
                </div>
                <div className="form-group">
                <label>Endereço</label>
                <input type="text" name="endereco" className="form-control" placeholder="Endereço"></input>
                </div>
                <div className="form-group">
                <label>Data</label>
                <input type="date" name="endereco" className="form-control" placeholder="Endereço"></input>
                </div>
                <div className="form-group">
                <label>Iniciativas</label>
                <select className="form-control">
                    <option>PyLadies</option>
                    <option>Django Girl</option>
                </select>
                </div>
            
                <button type="button" className="btn btn-primary">Enviar</button>
            </form>
            </div>
        );
    }
}

export default FormEvento;
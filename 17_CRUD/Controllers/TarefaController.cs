using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
// using CRUD.Models;

// A classe TarefaController é herdando seus metodos de Controller
public class TarefaController : Controller 
{
    // Criando um objeto _tarefas que armazenará uma lista de tarefas
    private static List<Tarefa> _tarefas = new List<Tarefa>();

    public IActionResult Index()
    {
        return View(_tarefas);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Adicionar(Tarefa novaTarefa)
    {
        // Verificando o total de tarefas da lista e simando mais 1 para criar o ID
        novaTarefa.Id = _tarefas.Count + 1;
        // Adicionar minha nova tarefa a minha lista
        _tarefas.Add(novaTarefa);
        // Redirecionando para pagina principal com a lista de tarefas
        return RedirectToAction("Index");
    }

    public IActionResult Editar(int Id)
    {
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);

        if (novaTarefa == null)
        return NotFound();

        return View(novaTarefa);
    }

    [HttpPost]
    public IActionResult Editar(Tarefa tarefaEditando)
    {
        Tarefa tarefaEncotrada = _tarefas.FirstOrDefault(t => t.Id == tarefaEditando.Id);
        if(tarefaEncotrada == null)
        return NotFound();

        tarefaEncotrada.Descricao = tarefaEditando.Descricao;
        tarefaEncotrada.Concluida = tarefaEditando.Concluida;
        return RedirectToAction("Index");
    }

     public IActionResult Deletar(int Id)
    {
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);

        if (novaTarefa == null)
        return NotFound();

        return View(novaTarefa);
    }

    [HttpPost]
    public IActionResult DeletarConfirmado(int Id)
    {
        Tarefa tarefaEncotrada = _tarefas.FirstOrDefault(t => t.Id == Id);
        if(tarefaEncotrada == null)
        return NotFound();

        _tarefas.Remove(tarefaEncotrada);
        return RedirectToAction("Index");
    }

}
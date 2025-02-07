﻿@ModelType Mvc_App_Crud.Aluno
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Aluno</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.AlunoNome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.AlunoNome)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Assunto.AssuntoInfo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Assunto.AssuntoInfo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Departamento.DepartamentoNome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Departamento.DepartamentoNome)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>

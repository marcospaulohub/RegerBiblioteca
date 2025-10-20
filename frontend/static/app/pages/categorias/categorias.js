const apiUrl = 'httpS://localhost:7237/api/categoria';
const form = document.getElementById('categoriaForm');
const tabelaBody = document.querySelector('#categoriasTable tbody');
const botaoCancelar = document.getElementById('cancelarEdicao');

let categoriaEditando = null;

console.log("ARQUIVO categorias...");

// Listar categorias
async function listarCategorias() {
console.log("Listando categorias...");

    try {
        const response = await fetch(apiUrl);
        if (!response.ok) throw new Error('Erro ao buscar categorias');
        const resultado = await response.json();
        const categorias = resultado.data || [];

        // Limpar tabela existente
        tabelaBody.innerHTML = '';

        if (categorias.length === 0) {
            tabelaBody.innerHTML = `<tr><td colspan="5" style="text-align:center; color:#777;">Nenhuma categoria encontrada</td></tr>`;
            return;
        }

        // Adicionar categorias à tabela
        categorias.forEach(categoria => {
            const row = document.createElement('tr');
            row.innerHTML = `
                <td>${categoria.nome}</td>
                <td>${categoria.descricao}</td>
                <td>${categoria.genero}</td>
                <td>${categoria.ativo ? 'Ativo' : 'Inativo'}</td>
                <td>
                    <button class="editar" data-id="${categoria.id}">Editar</button>
                    <button class="excluir" data-id="${categoria.id}">Excluir</button>
                </td>
            `;
            tabelaBody.appendChild(row);
        });
    } catch (error) {
        console.error('Erro ao listar categorias:', error);
    }

}

// Chamar a função para listar as categorias ao carregar a página
listarCategorias();
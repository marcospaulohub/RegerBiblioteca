const apiUrl = 'https://localhost:7237/api/usuario';
const form = document.getElementById('usuarioForm');
const tabelaBody = document.querySelector('#tabelaUsuarios tbody');
const campoSenha = document.getElementById('senha').closest('.form-group');
const botaoCancelar = document.getElementById('cancelarEdicao');

let usuarioEditando = null;

// Tipos de usuário
const tiposUsuario = {
    1: 'Aluno',
    2: 'Professor',
    3: 'Funcionário',
    4: 'Administrador',
    5: 'Visitante'
};

// Listar usuários
async function listarUsuarios() {
    try {
        const response = await fetch(apiUrl);
        if (!response.ok) throw new Error('Erro ao buscar usuários');
        const resultado = await response.json();
        const usuarios = resultado.data || [];

        tabelaBody.innerHTML = '';

        if (usuarios.length === 0) {
            tabelaBody.innerHTML = `<tr><td colspan="4" style="text-align:center; color:#777;">Nenhum usuário encontrado</td></tr>`;
            return;
        }

        usuarios.forEach(usuario => {
            const tr = document.createElement('tr');
            tr.innerHTML = `
                <td>${usuario.nome}</td>
                <td>${usuario.email}</td>
                <td>${tiposUsuario[usuario.tipoUsuario] || 'Desconhecido'}</td>
                <td class="acoes">
                    <button class="editar">Editar</button>
                    <button class="deletar">Excluir</button>
                </td>
            `;

            tr.querySelector('.editar').addEventListener('click', () => editarUsuario(usuario));
            tr.querySelector('.deletar').addEventListener('click', () => deletarUsuario(usuario));
            tabelaBody.appendChild(tr);
        });

    } catch (erro) {
        console.error(erro);
        alert('Não foi possível carregar os usuários.');
    }
}

// Salvar (Cadastrar ou Atualizar)
form.addEventListener('submit', async (e) => {
    e.preventDefault();

    const usuario = {
        nome: document.getElementById('nome').value,
        email: document.getElementById('email').value,
        senha: document.getElementById('senha').value,
        tipoUsuario: parseInt(document.getElementById('tipoUsuario').value)
    };

    try {
        let response;
        if (usuarioEditando) {
            response = await fetch(`${apiUrl}/${usuarioEditando.id}`, {
                method: 'PUT',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(usuario)
            });
        } else {
            response = await fetch(apiUrl, {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(usuario)
            });
        }

        const resultado = await response.json();
        if (!response.ok || !resultado.isSuccess) throw new Error(resultado.message || 'Erro ao salvar usuário.');

        alert(usuarioEditando ? 'Usuário atualizado com sucesso!' : 'Usuário cadastrado com sucesso!');
        resetarFormulario();
        listarUsuarios();

    } catch (erro) {
        console.error(erro);
        alert('Erro ao salvar o usuário: ' + erro.message);
    }
});

// Editar usuário
function editarUsuario(usuario) {
    usuarioEditando = usuario;
    document.getElementById('nome').value = usuario.nome;
    document.getElementById('email').value = usuario.email;
    document.getElementById('senha').value = '';
    document.getElementById('tipoUsuario').value = usuario.tipoUsuario;

    campoSenha.style.display = 'none';
    form.querySelector('button[type="submit"]').textContent = 'Atualizar';
    botaoCancelar.style.display = 'inline-block';
}

// Cancelar edição
botaoCancelar.addEventListener('click', () => {
    resetarFormulario();
});

// Deletar usuário
async function deletarUsuario(usuario) {
    if (!confirm(`Tem certeza que deseja excluir o usuário "${usuario.nome}"?`)) return;

    try {
        const response = await fetch(`${apiUrl}/${usuario.id}`, { method: 'DELETE' });
        const resultado = await response.json();
        if (!response.ok || !resultado.isSuccess) throw new Error(resultado.message || 'Erro ao excluir usuário.');

        alert('Usuário excluído com sucesso!');
        listarUsuarios();

    } catch (erro) {
        console.error(erro);
        alert('Erro ao excluir o usuário: ' + erro.message);
    }
}

// Função para resetar o formulário
function resetarFormulario() {
    form.reset();
    usuarioEditando = null;
    form.querySelector('button[type="submit"]').textContent = 'Cadastrar';
    campoSenha.style.display = 'block';
    botaoCancelar.style.display = 'none';
}

// Carregar lista ao iniciar
listarUsuarios();

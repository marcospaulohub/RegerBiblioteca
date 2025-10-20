const API_URL = 'https://localhost:7237/api/usuario';
const tabelaBody = document.getElementById('usuariosBody');
const formContainer = document.getElementById('formContainer');
const listaContainer = document.getElementById('listaContainer');
const usuarioForm = document.getElementById('usuarioForm');
const btnNovoUsuario = document.getElementById('btnNovoUsuario');
const btnCancelar = document.getElementById('btnCancelar');
const formTitle = document.getElementById('formTitle');
const senhaContainer = document.getElementById('senhaContainer');

const tiposUsuario = {
  1: 'Aluno',
  2: 'Professor',
  3: 'Funcionário',
  4: 'Administrador',
  5: 'Visitante'
};

let editandoUsuarioId = null;

// Carregar lista de usuários
async function carregarUsuarios() {
  const resp = await fetch(API_URL);
  const result = await resp.json();

  if (!result.isSuccess || !result.data) {
    tabelaBody.innerHTML = '<tr><td colspan="4">Erro ao carregar usuários</td></tr>';
    return;
  }

  tabelaBody.innerHTML = '';
  result.data.forEach(usuario => {
    const tr = document.createElement('tr');
    tr.innerHTML = `
      <td>${usuario.nome}</td>
      <td>${usuario.email}</td>
      <td>${tiposUsuario[usuario.tipoUsuario] || 'Desconhecido'}</td>
      <td>
        <button class="editar" onclick="editarUsuario('${usuario.id}')">Editar</button>
        <button class="deletar" onclick="deletarUsuario('${usuario.email}')">Excluir</button>
      </td>
    `;
    tabelaBody.appendChild(tr);
  });
}

// Mostrar formulário
btnNovoUsuario.addEventListener('click', () => {
  editandoUsuarioId = null;
  usuarioForm.reset();
  senhaContainer.style.display = 'block';
  formTitle.textContent = 'Novo Usuário';
  formContainer.style.display = 'block';
  listaContainer.style.display = 'none';
});

// Cancelar
btnCancelar.addEventListener('click', () => {
  formContainer.style.display = 'none';
  listaContainer.style.display = 'block';
});

// Salvar usuário
usuarioForm.addEventListener('submit', async (e) => {
  e.preventDefault();

  const usuario = {
    nome: document.getElementById('nome').value,
    email: document.getElementById('email').value,
    senha: document.getElementById('senha').value,
    tipoUsuario: parseInt(document.getElementById('tipoUsuario').value)
  };

  const metodo = editandoUsuarioId ? 'PUT' : 'POST';
  const url = editandoUsuarioId ? `${API_URL}/${editandoUsuarioId}` : API_URL;

  const resp = await fetch(url, {
    method: metodo,
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(usuario)
  });

  if (resp.ok) {
    alert('Usuário salvo com sucesso!');
    usuarioForm.reset();
    formContainer.style.display = 'none';
    listaContainer.style.display = 'block';
    carregarUsuarios();
  } else {
    alert('Erro ao salvar usuário.');
  }
});

// Editar
async function editarUsuario(id) {
  const resp = await fetch(`${API_URL}/${id}`);
  const result = await resp.json();
  const usuario = result.data;

  if (!usuario) {
    alert('Usuário não encontrado.');
    return;
  }

  editandoUsuarioId = usuario.id;
  document.getElementById('nome').value = usuario.nome;
  document.getElementById('email').value = usuario.email;
  document.getElementById('tipoUsuario').value = usuario.tipoUsuario;
  senhaContainer.style.display = 'none'; // Oculta campo senha ao editar

  formTitle.textContent = 'Editar Usuário';
  formContainer.style.display = 'block';
  listaContainer.style.display = 'none';
}

// Deletar
async function deletarUsuario(email) {
  if (!confirm('Tem certeza que deseja excluir este usuário?')) return;

  const resp = await fetch(`${API_URL}/${email}`, { method: 'DELETE' });

  if (resp.ok) {
    alert('Usuário excluído com sucesso!');
    carregarUsuarios();
  } else {
    alert('Erro ao excluir usuário.');
  }
}

// Inicializa
carregarUsuarios();

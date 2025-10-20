const links = document.querySelectorAll('.sidebar nav a');
const frame = document.getElementById('pageFrame');

// Quando clicar em um link, carrega a página dentro do iframe
links.forEach(link => {
  link.addEventListener('click', (e) => {
    e.preventDefault();

    // Remove classe ativa dos outros links
    links.forEach(l => l.classList.remove('active'));

    // Adiciona classe ativa no atual
    link.classList.add('active');

    // Define o src do iframe
    const page = link.getAttribute('data-page');
    frame.src = `pages/${page}`;
  });
});

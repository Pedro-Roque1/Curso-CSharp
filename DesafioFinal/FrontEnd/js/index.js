var listaPosts = new Vue({
  el: "#listagem",
  data() {
    return {
      lista: [],
    };
  },
  created() {
    var self = this;

    var xhr = new XMLHttpRequest();
    xhr.open("GET", "http://localhost:5000/Posts");
    xhr.addEventListener("load", function () {
      var resposta = xhr.responseText;
      self.lista = JSON.parse(resposta).slice(0, 10);
    });
    xhr.send();
  }
});





var pesquisa = new Vue({
    el: "#pesquisa",
    data: {
        post: [],
        busca:''
    },
    created() {
        var self = this;
        var pesquisa = self.busca;
        var xhr = new XMLHttpRequest();
        xhr.open("GET", `http://localhost:5000/Posts/Index/${pesquisa}`);
        xhr.addEventListener("load", function () {
            var resposta = xhr.responseText;
            self.lista = JSON.parse(resposta).slice(0, 10);
        });
        xhr.send();
    }
});

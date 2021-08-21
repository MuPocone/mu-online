import { Component, OnInit, AfterContentInit } from "@angular/core";

interface Noticia {
  id: number;
  dataCriacao: Date;
  titulo: string;
  corpoNoticia: string;
  expandad: boolean;
}

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
  styleUrls: ["./home.component.scss"],
})
export class HomeComponent implements OnInit, AfterContentInit {
  constructor() {}

  noticias: Noticia[] = [];

  ngOnInit(): void {
    this.criaNoticiaFake();
  }

  ngAfterContentInit() {}

  obterNoticia(): Noticia {
    const noticia: Noticia = {
      id: 1,
      dataCriacao: new Date(),
      titulo: "Noticia",
      corpoNoticia: `<p style="text-align: center;">
      <img
        alt=""
        src="https://i.imgur.com/KUx6Ph7.jpg"
        style="height: 148px; width: 588px;"
      />
    </p>

    <p style="text-align: center;">&nbsp;</p>

    <p style="text-align: center;">
      <span style="color: #8e44ad;"
        ><em
          ><strong
            >Event Period: 02/06 after maintenance&nbsp;~ 09/06&nbsp;before
            maintenance.</strong
          ></em
        ></span
      ><br />
      &nbsp;
    </p>

    <p>
      <br />
      <strong
        ><span style="color: #c0392b;"
          ><span style="font-size: 16px;"
            >The Golden Colossus&nbsp;</span
          ></span
        ></strong
      ><br />
      The continent of MU is under attack! Protect the land from an invasion
      of Golden Monsters to unlock random rewards which may include jewels,
      zen, misc, and <span style="color: #2980b9;">Angel</span
      ><span style="color: #c0392b;"> </span>&amp;
      <span style="color: #c0392b;">Devil</span> wings. Golden Goblins have
      been released into the lands of Kanturu, Aida, Tarkan, Karutan and
      Acheron. When defeated, these creatures may drop a
      <span style="color: #8e44ad;">Book of Invocation</span> that will
      summon&nbsp;other
      <span style="color: #f1c40f;">Golden Monsters.</span>
    </p>

    <p>
      <br />
      <strong
        ><span style="color: #c0392b;"
          ><span style="font-size: 16px;">+1.15X&nbsp;EXP Event</span></span
        ></strong
      ><br />
      Enjoy your FREE time during this week and boost your level with
      this&nbsp;<strong>EXP Boost</strong>&nbsp;take advatange of our awesome
      events (devil square, blood castle and so on) to event boost yourself
      more!&nbsp;<span style="color: #e74c3c;"
        ><strong>Happy Gaming.</strong></span
      ><br />
      <br />
      <br />
      <span style="color: #c0392b;"
        ><span style="font-size: 16px;"
          ><strong>Master Level Packages Promotion</strong></span
        ></span
      ><br />
      Get our Master Level Packages and Boost your Level Up for Cheap! Get a
      bunch of bonuses and buffs for heavily discounted price when purchased
      all together with our package and a lot of freebies. There are 3
      packages with different setups for your like.<br />
      <br />
      <strong>Note:</strong> Remember these are only temporal and will be
      removed after event period ends.<br />
      <br />
      <br />
      <strong
        ><span style="color: #c0392b;"
          ><span style="font-size: 16px;">Gift a Goblin Point</span></span
        ></strong
      ><br />
      During the event period you will be able to gift 500, 1000 and 2000
      goblin points to other characters. You can buy goblin points boxes in
      our xshop in event tab, those boxes can be gifted, traded and sold
      through personal store.<br />
      <br />
      <br />
      <span style="color: #c0392b;"
        ><span style="font-size: 16px;"
          ><strong>Seasonal Muuns</strong></span
        ></span
      ><br />
      Go and collect <span style="color: #8e44ad;">muun eggs</span> and
      release the power of these bad boys, these are special seasonal muuns
      that comes with more than good options like increase
      <span style="color: null;"
        >critical damage, repair fee reduction, attack skill and increase
        attack power.</span
      ><br />
      &nbsp;
    </p>

    <p style="text-align: center;">
      <br />
      <img
        alt=""
        src="https://i.imgur.com/1GqGzUq.jpg"
        style="height: 222px; width: 694px;"
      />
    </p>`,
      expandad: false,
    };
    return noticia;
  }

  async criaNoticiaFake() {
    for (let index = 0; index < 10; index++) {
      this.noticias.push(this.obterNoticia());
    }

    this.noticias = await this.noticias.sort((a: Noticia, b: Noticia) => {
      return this.getTime(a.dataCriacao) - this.getTime(b.dataCriacao);
    });

    this.noticias[0].expandad = true;
  }

  private getTime(date?: Date) {
    return date != null ? new Date(date).getTime() : 0;
  }
}

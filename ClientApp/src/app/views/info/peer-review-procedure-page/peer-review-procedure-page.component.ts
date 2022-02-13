import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-peer-review-procedure-page',
  templateUrl: './peer-review-procedure-page.component.html',
  styleUrls: ['./peer-review-procedure-page.component.scss']
})
export class PeerReviewProcedurePageComponent implements OnInit {

  evaluations: evaluation[] = [
    {
      imgSrc: '../../../../assets/images/info/peer-review/checklist.png',
      texts: [
        'The Editor in Chief and the Editorial Board examine the paper for its quality and appropriateness for review. If the criteria set are not met, the manuscript is rejected, and the author duly informed. '
      ]
    },
    {
      imgSrc: '../../../../assets/images/info/peer-review/examine.png',
      texts: [
        "The Editor in Chief sends the article-identifying information having been removed, to three reviewers. Normally, one of these is from the Journal's editorial board. Others are experts in the subject matter represented by the article. The Editor in Chief asks them to complete the review in three weeks.",
        "Comments to authors are about the appropriateness and adequacy of the theoretical or conceptual framework, literature review, method, results and discussion, implications to society, practice, theory and method, and conclusions. Reviewers often include suggestions for the strengthening of the manuscript. Comments to the editor are in the nature of the significance of the work and its potential contribution to the literature.",
        "For full information, reviewers are directed to read Reviewers’ Guidelines of the IJCAI."
      ]
    },
    {
      imgSrc: '../../../../assets/images/info/peer-review/directional-sign.png',
      texts: [
        "The Editor in Chief and on consultation with the Guest Editor examines the review and decides whether to reject the manuscript, invites the author(s) to revise and resubmit the manuscript, or seeks additional review. Final acceptance or rejection rests with the Editor in Chief, who reserves the right to refuse any material for publication. In exceptional cases, the manuscript is accepted with virtually no revision. As a practice and without exception, reviewers' comment (to the author) is forwarded to the author. If a correction is specified, the editor provides guidelines for attending to the reviewers' suggestions and perhaps additional advice about the manuscript revision. "
      ]
    },
    {
      imgSrc: '../../../../assets/images/info/peer-review/decision-making.png',
      texts: [
        "The authors have to make a decision as to the best approach to address the reviewers' comments and criticisms as well as the Guest editor's concerns. The authors return a revised version of the paper to the Guest Editor along with accurate information describing in a tabular form how they have answered the apprehensions of the reviewers and the Guest Editor. The author(s) may also submit a rebuttal if there is a need especially when the author disagrees with certain comments provided by reviewer(s)."
      ]
    },
    {
      imgSrc: '../../../../assets/images/info/peer-review/guest-list.png',
      texts: [
        "The Guest Editor sends the revised paper out for re-review. Usually, at least one of the original reviewers will be requested to re-examine the article. "
      ]
    },
    {
      imgSrc: '../../../../assets/images/info/peer-review/revision.png',
      texts: [
        "When the reviewers have completed their work, the Guest Editor in discussion with the Editorial Board and the Editor-in-Chief examines their comments and decides whether the paper is ready to be published, requires another round of revisions, or stands rejected. "
      ]
    },
    {
      imgSrc: '../../../../assets/images/info/peer-review/printer.png',
      texts: [
        "If the decision is to accept, an acceptance letter is sent to all the author(s), the paper is referred to the Press. The article should appear first in early print and later in the permanent edition. "
      ]
    }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}

interface evaluation {
  imgSrc: string
  texts: string[]
}

import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { ChallengeItemComponent } from './challenge-item.component';
//
import { Challenge } from 'src/app/core/models';
import { DebugElement } from '@angular/core';

import { format } from 'date-fns';

describe('ChallengeItemComponent', () => {
  let component: ChallengeItemComponent;
  let fixture: ComponentFixture<ChallengeItemComponent>;
  let challengeItemDe:DebugElement;
  let challengeItemNativeElement:HTMLElement;
  let inputTestChallenge:Challenge;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ ChallengeItemComponent ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(ChallengeItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
      challengeItemDe = fixture.debugElement;
      challengeItemNativeElement = challengeItemDe.nativeElement; 
  }));

  beforeEach(()=>{
    inputTestChallenge = {
      id: 'Guid stuff',
      description:'To play soccer',
      title:'Event Title',
      startDate: new Date(),
      endDate: new Date(),
      price:'R500'
    }
    component.challenge = inputTestChallenge;
    //we need to detect changes
    fixture.detectChanges();
   
  })

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('given challenge object should render all challenge properties',()=>{
     //check if the item rendered correct data    
    const challengeTitleElem = challengeItemNativeElement.querySelector("#challenge-title")!;
    expect(challengeTitleElem.textContent).withContext("title should be rendered").toEqual(`${inputTestChallenge.title}`)  
    })

  it('given challenge object should render date element',()=>{
    const challengeDateElem = challengeItemNativeElement.querySelector("#challenge-date")!;
    expect(challengeDateElem.textContent).withContext("date should be rendered and formated").toEqual(`${format(inputTestChallenge.startDate, "MMM dd, yyyy") } to ${ format(inputTestChallenge.endDate,'MMM dd, yyyy')}`);
  })

  it('given challenge object render price element',()=>{
    const challengePriceElem = challengeItemNativeElement.querySelector("#challenge-price")!;
    expect(challengePriceElem.textContent).withContext("price should be rendered").toEqual(`Win: ${inputTestChallenge.price}`);
  })

  it('given challenge object render description',()=>{
    const challengeDescription = challengeItemNativeElement.querySelector("#challenge-description")!;
    expect(challengeDescription.textContent).withContext("description should be rendered").toEqual(`${inputTestChallenge.description}`)
  })


});

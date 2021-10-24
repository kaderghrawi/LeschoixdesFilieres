using System;
using System.Collections.Generic;
using System.Text;

namespace LeschoixdesFilieres
{
  class StringSplitOptions
  {
  public String monChoix;
 public int placesFiliere;
 public StringSplitOptions()
 {
 }
 public StringSplitOptions(String monChoix, int placesFiliere)
 {
  this.MomChoix =MomChoix;
 this.placesFiliereGLABDASR = placesFiliere;
  }

  public object MomChoix { get; }
 public int placesFiliereGLABDASR { get; private set; }
    }
}

